var express = require('express'),
    morgan = require('morgan'),
    cors = require('cors'),
    bodyParser = require('body-parser');

var app = express();
app.use(morgan('dev'));
app.use(cors());
app.use(bodyParser.json());

app.use('/', require('./controllers/serviceController.js'));

var port = process.env.port || 3001;
app.listen(port, () => {
  console.log(`BUS is running on port ${port}`);
});