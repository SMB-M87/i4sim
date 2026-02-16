# Industry 4.0 Simulation Environment

![Afbeelding1](https://github.com/user-attachments/assets/39305057-47e9-4c2e-9c13-7e400c621a7d)

This repository contains a sophisticated simulation environment aimed at Industry 4.0 applications. The simulation provides a flexible platform for modeling smart factory scenarios involving autonomous production and transport units. These simulated units communicate via a decentralized bidding procedure, enabling detailed analysis, testing and optimization of dynamic factory processes. See [video](https://www.youtube.com/watch?v=Y9loZ_bbvng&ab_channel=SMB-M87) for an indepth demonstration.

## Key Objectives

![Afbeelding2](https://github.com/user-attachments/assets/1347c148-e8f0-42dc-8e90-a273609069ad)

- Simulate realistic behaviors of modular and autonomous units within a smart factory.
- Provide real-time interaction and visualization of transport and production dynamics.
- Integrate with external bidding systems via MQTT for comprehensive testing.
- Benchmark performance and reliability through extended runtime simulations.

## Core Features

Event-Driven Architecture
- Powered by Akka.NET for fully asynchronous and event-driven execution.
- Modular actor-based logic enables concurrent behavior and scalability.

Advanced 2D Visualization
- Real-time rendering using Vortice.Direct2D1.
- Visual layers include:
  - Collision zones
  - Detection radii
  - Motion vectors
  - Path overlays

MQTT Integration
- Seamless communication with external bidding platforms.
- Simulated units act as independent digital agents capable of bidding, negotiating and executing.

Runtime Interaction
- Full user control: toggle parameters, switch overlays, pause/resume cycles.
- Interactive unit inspection and status control with mouse events.

Logging & Benchmarking
- Automatic generation of runtime dumps and logs.
- Metrics include:
  - Collisions
  - Task durations
  - Product throughput
  - Movement efficiency

## Technical Stack

- Programming Language: C# (.NET 8)
- Concurrency Model: Akka.NET (Actors)
- Rendering: Vortice.Direct2D1
- Communication: MQTT protocol via custom client actors
- Platform: Windows (native Win32 integration)

## Repository Structure

```text
Simulation/  
├─ Blueprints/                # JSON configurations for factory setups  
├─ Dummy/                     # Dummy product generation system  
├─ MQTT/                      # MQTT client and actor implementations  
├─ UnitProduction/            # Logic for production units  
├─ UnitTransport/             # Logic for transport units     
└─ Environment.cs             # Central data model of the simulation
Win32/                        # Native window management and rendering
```

![Afbeelding3](https://github.com/user-attachments/assets/862ac2fd-ca01-4a71-8050-369d6fd193dd)

![Afbeelding4](https://github.com/user-attachments/assets/cb49eb80-39b6-4ee1-9115-7a0b8aff206a)

![Afbeelding5](https://github.com/user-attachments/assets/5a5ef722-5ae5-4afd-b3af-16634d7e285d)

![Afbeelding6](https://github.com/user-attachments/assets/b2ada7ed-4085-4907-860f-e9042d72e7c8)

## Getting Started

- Launching the Simulation
  - Start the application executable.
  - Select a JSON blueprint (e.g., MAS-demonstrator) from the load screen.
  - Simulation starts paused, allowing configuration adjustments.

![image](https://github.com/user-attachments/assets/f5701497-97c2-4128-a4dd-19d8e25c77dc)
![image](https://github.com/user-attachments/assets/1afa6d67-9881-4fd6-8061-14a93acafdd4)
![image](https://github.com/user-attachments/assets/eb2c522d-db18-47d3-8a3a-8da95d17f9a9)

- Configuration Options
  - Adjust simulation speed (UPS/FPS).
  - Toggle visual overlays (paths, collision zones, debug vectors).
  - Activate logging (MQTT, movers, products).

![image](https://github.com/user-attachments/assets/1e59de91-bb29-4dbb-a381-e724cb86be56)

- Runtime Interaction
  - Right-click: Toggle unit statuses (Alive/Blocked).
  - Left-click: Inspect detailed real-time unit data.
  - Settings panel: Modify visualizations, pause/resume, or terminate simulation.

![image](https://github.com/user-attachments/assets/40f81037-d18d-4f7e-af30-43eb6c55f5ba)
![image](https://github.com/user-attachments/assets/ad5056ef-2be9-4555-a693-3faf923c7462)

- Post-Simulation Analysis
  - Automatic dump files stored in the Output/ directory.
  - Analyze logs for benchmarking, performance statistics, and collision analysis.

![Afbeelding7](https://github.com/user-attachments/assets/27dd7fb7-eb94-4746-bb3b-7c315987a79f)
![Afbeelding8](https://github.com/user-attachments/assets/0817a39f-a117-4f1e-a4ac-325282dc5115)
![Afbeelding9](https://github.com/user-attachments/assets/f6bbed61-551c-4f06-9d03-4176a09c865d)
![Afbeelding10](https://github.com/user-attachments/assets/f958f02a-9557-4c9e-8452-5f42cadd3e2f)
![Afbeelding11](https://github.com/user-attachments/assets/aafc8bdc-1937-4a7b-98b4-f8b668a29cf2)
![Afbeelding12](https://github.com/user-attachments/assets/f46f86a3-cc86-4d47-899a-938994cc7917)
![Afbeelding13](https://github.com/user-attachments/assets/479322dc-8727-4f75-b9e8-425c006328c0)
