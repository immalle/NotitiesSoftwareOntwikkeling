# DateTime

Een `DateTime` is eigenlijk een `struct`.

Er zijn wel constructors om nieuwe DateTime-objecten te maken:

```cs
DateTime jeuj = new DateTime(1981, 10, 19, 12, 0, 5);
```

Je kan 2 `DateTime`-objecten ook van elkaar aftrekken,
je krijgt dan iets terug van type `TimeSpan`.

```cs
TimeSpan ts = DateTime.Now - jeuj;
```

# Voorbeeld

https://dotnetfiddle.net/ig7NRG
