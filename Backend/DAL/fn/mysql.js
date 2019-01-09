var mysql = require('mysql');

var createConnection = () => {
  return mysql.createConnection({
    host: 'localhost',
    port: 3306,
    user: "root",
    password: "",
    database: "qlttnn"
  });
}

exports.load = function(sql) {
  return new Promise((resolve, reject) => {
      var cn = createConnection();
      cn.connect();
      cn.query(sql, function(error, rows, fields) {
          if (error) {
              reject(error);
          } else {
              resolve(rows);
          }
          cn.end();
      });
  });
}
