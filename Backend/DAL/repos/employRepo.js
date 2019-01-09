var db = require('../fn/mysql.js');
var tableName = "employee";

exports.loadAll = () => {
  var sql = `select * from ${tableName}`;
  return db.load(sql);
}