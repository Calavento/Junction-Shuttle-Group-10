# Junction Shuttle Booking System

**Group 10**| See [GROUP_MEMBERS.md](GROUP_MEMBERS.md)

A Visual Basic (.NET Windows Forms) app for booking seats on the Madina Zongo Junction - Dodowa shuttle route.

## Features
- Pick route, date, departure time, boarding stop and drop-off stop
- Fare is calculated automatically from the distance between stops (GH₵)
- Interactive 15-seat map: green = free, red = taken, gold = selected
- Seat availability is per segment, so a seat freed at an earlier drop-off can be rebooked
- Passenger name and Ghana mobile number validation
- Booking receipt with a cancel option
- Driver manifest for each trip, which can be sent to the driver via WhatsApp

## Run it
1. Install Visual Studio 2022+ with the **.NET desktop development** workload (.NET 10 SDK).
2. Open `JUNCTION SHUTTLE.slnx`.
3. Press **F5**.

## Files
| File | Purpose |
|------|---------|
| `Form1.vb` | Main booking screen, seat map, fare and validation |
| `frmReceipt.vb` | Receipt and cancellation |
| `frmManifest.vb` | Driver manifest and WhatsApp send |
| `Booking.vb` | Booking data class |
