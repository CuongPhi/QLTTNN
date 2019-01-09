var express = require('express');

var route = express.Router();
var service = require('../services/service.js');

route.get('/course', (req, res) => {
  service.getCourse(req, res);
})

route.get('/employee', (req, res) => {
  service.getEmployee(req, res);
})

route.get('/manager', (req, res) => {
  service.getManager(req, res);
})

route.get('/student', (req, res) => {
  service.getStudent(req, res);
})

route.get('/notification', (req, res) => {
  service.getNotification(req, res);
})

module.exports = route;