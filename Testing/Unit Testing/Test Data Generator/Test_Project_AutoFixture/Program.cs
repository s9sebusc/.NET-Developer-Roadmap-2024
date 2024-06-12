using AutoFixture;
using AutoFixture.AutoMoq;
using Test_Project_AutoFixture;

Fixture fixture = new Fixture();

// Create simple types
string dummyString = fixture.Create<string>();
int dummyInteger = fixture.Create<int>();

// Create complex types
Order orderMock = fixture.Create<Order>(); // Initialisiert die komplette Instance von Fixture

// CreateMany
IEnumerable<BillingDetails> billingDetailsMocks = fixture.CreateMany<BillingDetails>(); // Initialisiert mehrere Instanzen

// Register DI
fixture.Register<IDummyService>(() => new DummyServiceMock());
IDummyService? dummyServiceMock = fixture.Create<IDummyService>();


// Set properties for complex types
Order? specificOrder = 
	fixture.Build<Order>()
		.With(x => x.Id, Guid.NewGuid)
		.With(x => x.Price, (decimal)99.99)
		.With(x => x.Comment, "bla")
		.OmitAutoProperties() // andere Properties soll nicht initialisiert werden
		.Create();

// Remove properties
specificOrder =
	fixture.Build<Order>()
		.With(x => x.Id, Guid.NewGuid)
		.Without(x => x.Price) // null
		.Without(x => x.Comment) // null
		.Create();



// Combine multiple mocks
BillingDetails billingDetailsMock = fixture.Create<BillingDetails>();
specificOrder = 
	fixture.Build<Order>()
		.With(x => x.Id, Guid.NewGuid)
		.With(x => x.BillingDetails, billingDetailsMock)
		.Do(x => x.BillingDetails = billingDetailsMock)
		.Create();
var order = fixture.Create<Order>();

// AutoMoq
fixture.Customize(new AutoMoqCustomization() );
fixture.Inject<IDummyService>(new DummyServiceMock()); // Return custom mock 
IDummyService? interfaceMock = fixture.Create<IDummyService>();

// AutoMoq - ConfigureMembers = true
fixture.Customize(new AutoMoqCustomization() { ConfigureMembers = true }); // Auch die Members werden generiert


