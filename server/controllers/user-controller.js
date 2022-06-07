const db = require('../models/data-model')

exports.login = (req, res) => {
db.getAllUsers(req.body.username, (results) => {
    if(results[0]){
        res.send(true);
    }else{
        res.send(false);
    }
})
}