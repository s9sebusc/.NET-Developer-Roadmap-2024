using Bridge;

// Select control type
IControl remoteControl = new RemoteControl();
IControl manual = new ManualControl();

HomeDevice TV = new TV(remoteControl);
TV.TurnOn();
TV.TurnOff();

HomeDevice Lamp = new Lamp(manual);
Lamp.TurnOn();
Lamp.TurnOff();

