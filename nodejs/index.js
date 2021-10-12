require('dotenv').config()
const express = require('express')
const app = express()
const port = 3000
app.use(express.text())


app.post('/', (req, res) =>{

  /// Add your code here to upload to blob storage.
  /// This project already contains dotenv. Add the storage connection string in the Azure Portal to your .env file.
  /// You can access the storage connection string via process.env.STORAGE_CONNECTION_STRING
    if(!req.body)
    {
        res.send("File was not found");
        return;
    }
    res.send(req.body)
})

app.get('/', (req, res) => {

  /// add your code here to  retrieve a list of blobs.
  res.send("a log response!")
})


app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})