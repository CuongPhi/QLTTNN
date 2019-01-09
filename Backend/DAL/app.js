var express = require('express'),
    cors = require('cors'),
    morgan = require('morgan'),
    bodyParser = require('body-parser');

var app = express();
app.use(morgan('dev'));
app.use(bodyParser.json());
app.use(cors());

var courseController = require('./controllers/courseController.js');
var employController = require('./controllers/employController.js');
var managerController = require('./controllers/managerController.js');
var studentController = require('./controllers/studentController.js');
var notificationController = require('./controllers/notificationController.js');

app.use('/course', courseController);
app.use('/employee', employController);
app.use('/manager', managerController);
app.use('/student', studentController);
app.use('/notification', notificationController);

var port = process.env.port || 3000;
app.listen(port, () => {
  console.log(`DAL server is running on port ${port}`);
})