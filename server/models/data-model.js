let db = require('../Database/db-settings');

exports.getAllUsers =  (user ,callback) => {
db.connection.query('SELECT * FROM USERS WHERE USERNAME = ?', user , (err, results) => {
    if(err) throw err;
    db.connection.destroy;
    return callback(results);
})
}