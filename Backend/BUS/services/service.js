var axios = require('axios');
var urlDAL = 'http://localhost:3000/'

exports.getCourse = (req, res) => {
  getDataRequest(req, res, 'course');
}

exports.getEmployee = (req, res) => {
  getDataRequest(req, res, 'employee');
}

exports.getManager = (req, res) => {
  getDataRequest(req, res, 'manager');
}

exports.getStudent = (req, res) => {
  getDataRequest(req, res, 'student');
}

exports.getNotification = (req, res) => {
  getDataRequest(req, res, 'notification');
}

getDataRequest = (req, res, str) => {
  var urls = urlDAL + str;
  axios.get(urls)
  .then(rs => {
    res.json(rs.data);
  });
}