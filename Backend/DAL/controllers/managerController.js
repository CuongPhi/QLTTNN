var express = require('express');

var route = express.Router();
var managerRepo = require('../repos/managerRepo.js');

route.get('/', (req, res) => {
  managerRepo.loadAll()
  .then(rows => {
    res.json(rows);
  }).catch(err => {
    console.log(err);
    res.statusCode = 500;
    res.end('View error on console');
  });
});

module.exports = route;