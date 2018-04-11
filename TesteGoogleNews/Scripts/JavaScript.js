var url = 'https://newsapi.org/v2/top-headlines?' +
    'country=us&' +
    'apiKey=ee7312c8b0f44998869ad733e5c8c41a';
var req = new Request(url);
fetch(req)
    .then(function (response) {
        console.log(response.json());
    })