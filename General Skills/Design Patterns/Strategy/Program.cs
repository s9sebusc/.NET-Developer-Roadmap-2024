using Strategy;

IAirportTransportationStrategy busTransport = new BusStrategy();
TravelManager travelManager = new TravelManager();
travelManager.SetStrategy(busTransport);
travelManager.Travel();

IAirportTransportationStrategy carTransport = new CarStrategy();
travelManager = new TravelManager();
travelManager.SetStrategy(carTransport);
travelManager.Travel();

