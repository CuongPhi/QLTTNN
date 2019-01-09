var express = require('express');

var route = express.Router();

var courseRepo = require('../repos/courseRepo.js');

route.get('/', (req, res) => {
  courseRepo.loadAll()
  .then(rows => {
    res.json(rows);
  }).catch(err => {
    console.log(err);
    res.statusCode = 500;
    res.end('View error on console');
  });
});

module.exports = route;