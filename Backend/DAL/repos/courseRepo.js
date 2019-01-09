var db = require('../fn/mysql.js');
var tableName = 'course';

exports.loadAll = () => {
  var sql = `select * from ${tableName}`;
  return db.load(sql);
}