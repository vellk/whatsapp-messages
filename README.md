# WhatsApp Message Templates

A .NET library for managing WhatsApp message templates. This library provides a strongly-typed way to work with WhatsApp Business API message templates.

## Features

- Strongly typed models for WhatsApp message templates
- Support for different types of template components
- JSON serialization support
- Language configuration

## Project Structure

```
Models/
├── Component.cs         # Message component model
├── Language.cs         # Language configuration
├── Template.cs         # Main template model
├── WhatsAppMessage.cs  # WhatsApp message model
└── Parameters/         # Various parameter types
    ├── ButtonParameter.cs
    ├── Currency.cs
    ├── Media.cs
    └── Parameter.cs
```

## Technologies

- .NET 8.0
- System.Text.Json for JSON serialization

## Getting Started

To use this library in your project:

1. Add the project reference to your solution
2. Import the namespace:
```csharp
using WhatsAppTemplates.Models;
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.