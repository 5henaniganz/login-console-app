const express = require('express')

const app = express()

app.use(express.json())

app.use(express.urlencoded({ extended: true }))

require('./routes/login-routes')(app)

const PORT = process.env.PORT || 8080

app.listen(PORT, () => {
  console.log(`Server running on port: ${PORT}`)
})