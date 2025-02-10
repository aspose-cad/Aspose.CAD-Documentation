const express = require('express');
const path = require('path');

const app = express();
const PORT = 8080;

app.use((req, res, next) => {
  console.log(`[${new Date().toISOString()}] ${req.method} ${req.protocol}://${req.get('host')}${req.originalUrl}`);
  next();
});

// Serve static files from the "public" directory
app.use('/cad', express.static(path.join(__dirname, '../public')));

// Start the server
app.listen(PORT, () => {
  console.log(`Server is running at http://localhost:${PORT}/cad`);
});
