# Virtual-Reality-Connective-Tissue


![ezgif-7-c2508e0427](https://user-images.githubusercontent.com/444888/150306532-bf11af13-1b0a-4d2d-97e4-647b6105a7b3.gif)

![Screen Shot 2022-01-20 at 1 58 53 AM](https://user-images.githubusercontent.com/444888/150306562-a3c2f98e-9790-49e3-8add-ea4a5c51793b.png)

![Screen Shot 2022-01-20 at 1 59 21 AM](https://user-images.githubusercontent.com/444888/150306592-528281ac-6e14-4c7f-867c-88d9ba7be310.png)

![Image from iOS](https://user-images.githubusercontent.com/444888/150307233-bdf7d046-8547-4195-9ed6-73dbd185a517.jpg)

```
const fs = require('fs');
const http = require('http');
const gpio = require('onoff').Gpio;

const relays = [
  new gpio(26, 'out'),
  new gpio(20, 'out'),
  new gpio(21, 'out')
];

const allRelaysOff = () => {
  relays.forEach(relay => relay.writeSync(0));
};

const relayServer = (request, response) => {
  let requestBody = '';

  request.on('data', chunk => {
    requestBody = `${requestBody}${chunk.toString()}`;
  });

  request.on('end', () => {
    // Check request method is valid.
    if (!['GET', 'POST'].includes(request.method)) {
      response.writeHead(500);
      response.end('Bad request.');
      return;
    }

    if (request.url === '/') {
      console.log('Home page requested.');
      fs.readFile('index.html', (error, content) => {
        response.writeHead(200, { 'Content-Type': 'text/html' });
        response.end(content, 'utf-8');
      });

      return;
    }

    if (['/relays/1', '/relays/2', '/relays/3'].includes(request.url)) {
      response.writeHead(200);
      let relayNumber = parseInt(
        request.url.substring(request.url.length - 1),
        10
      );

      // Take 1 off of relayNumber as arrays are indexed.
      relayNumber = relayNumber - 1;

      if (request.method === 'POST') {
        // Parse the request body JSON.
        try {
          const r = JSON.parse(requestBody);

          if (r.state === true) {
            relays[relayNumber].writeSync(1);
            console.log(`Switched relay ${relayNumber} on.`);
          } else if (r.state === false) {
            relays[relayNumber].writeSync(0);
            console.log(`Switched relay ${relayNumber} off.`);
          } else {
            response.writeHead(500);
            response.end('Bad request.');
            return;
          }
        } catch (e) {
          response.writeHead(500);
          response.end('Bad request.');
          return;
        }
      }

      // Return true if the relay is on, otherwise false.
      response.end(relays[relayNumber].readSync() === 1 ? 'true' : 'false');
      return;
    } else {
      // If we get to here, we have an unknown request.
      response.writeHead(404);
      response.end('Not found.');
    }
  });
};

// Turn off all relays on start up.
allRelaysOff();

// Create a web server and listen on 8888.
http.createServer(relayServer).listen(8888);

// Handle Ctrl+C exit cleanly by turning off all relays.
process.on('SIGINT', () => {
  allRelaysOff();
  process.exit();
});

```
