const controller = require('../controllers/user-controller');

module.exports = function (app) {

app.post('/', controller.login)

}