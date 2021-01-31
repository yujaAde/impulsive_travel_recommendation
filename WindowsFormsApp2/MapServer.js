var http = require('http');
var fs = require('fs');

function send404Message(response) {
    
}

function onRequest(request, response) {
    if (requiest.method == 'GET' && request.url == '/') {
        response.writeHead(200, { "Content-Type": "text/html" });
        fs.createReadStream("./MapPage.html").pip(response);
    }

    http.createServer(onRequest).listen(8080);
    console.log("end");
}