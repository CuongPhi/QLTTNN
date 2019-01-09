var express = require('express');

var route = express.Router();
var employRepo = require('../repos/employRepo.js');

route.get('/', (req, res) => {
  employRepo.loadAll()
  .then(rows => {
    res.json(rows);
  }).catch(err => {
    console.log(err);
    res.statusCode = 500;
    res.end('View error con console');
  })
});

module.exports = route;