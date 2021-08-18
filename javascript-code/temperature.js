const Temperature = {
  fahrenheitToCelsius: (temperature) => Number.parseFloat((temperature - 32) / 1.8).toFixed(2),
};

module.exports = Temperature;
