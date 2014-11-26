OpenBacklight
=============

An open source project for computer backlighting systems that can be constructed from inexpensive hardware.

Features:
  - Estimates the average color of your main display in real time.
  - Communicates the color data in a generic format over USB, to be captured by a low-cost microprocessor.
  - Minimizes to the system tray for easy access.
  - Lightweight, with minimal impact on system resources.

Planned Features:
  - Modular, plugin-based design to support interface extensions and other hardware.
  - Arduino library for easy development of custom hardware implementations.
  - MSP-430 support.
  - Support for multiple displays, with color data seperated based on zones accross displays.
  - Adaptive color sensing, for improved accuracy based on user activity.
  - Hardware or software-based audio input for sound visualization.
  - Interfacing with popular games and applications.

Status:
  Harware development for a reference device has been completed, but problems with color detection during full-screen DirectX and OpenGL games has led to a major delay.
