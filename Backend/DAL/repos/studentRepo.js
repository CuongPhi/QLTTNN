var db = require('../fn/mysql.js');
var tableName = "student";

exports.loadAll = () => {
  var sql = `select * from ${tableName}`;
  return db.load(sql);
}
