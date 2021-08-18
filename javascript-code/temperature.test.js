const Temperature = require('./temperature');

describe('Temperature Conversor', () => {
  it.each([
    [32, 0],
    [47, 8.33],
    [86, 30],
    [90.5, 32.5],
    [120.18, 48.99],
    [212, 100],
  ])(
    'Given %p When convert temperature from fahrenheit to celsius Then return %p',
    (fahrenheit, celsius) => {
      expect(Temperature.fahrenheitToCelsius(fahrenheit)).toBe(
        Number.parseFloat(celsius).toFixed(2)
      );
    }
  );
});
