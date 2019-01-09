var express = require('express');

var route = express.Router();
var notificationRepo = require('../repos/notificationRepo.js');

route.get('/', (req, res) => {
  notificationRepo.loadAll()
  .then(rows => {
    res.json(rows);
  }).catch(err => {
    console.log(err);
    res.statusCode = 500;
    res.end('View error con console');
  });
});

module.exports = route;