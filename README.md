# Vision - Professional Presentation Software

![C#](https://img.shields.io/badge/Language-C%23-blue)
![.NET](https://img.shields.io/badge/.NET-10.0-blue)
![WPF](https://img.shields.io/badge/Framework-WPF-purple)
![License](https://img.shields.io/badge/License-MIT-green)

## 📺 Description

**Vision** is a professional presentation software for:
- ⛪ Churches and religious organizations
- 🎤 Live events and conferences
- 🎓 Educational presentations
- 🎬 Audiovisual productions

## ✨ Features

✅ **Control Center** - Main window with complete control
✅ **Output Window** - Full-screen presentation display
✅ **Slide Management** - Organize slides in groups
✅ **Smooth Transitions** - Professional fade in/out effects
✅ **Custom Backgrounds** - Support for colors and images
✅ **Modular Architecture** - Easy to extend

## 🚀 Requirements

- **.NET 10.0** or higher
- **Windows 10** or higher
- **Visual Studio 2022** or higher
- **2 monitors** (recommended)

## 📦 Installation

### Clone and Build

```bash
# Clone the repository
git clone https://github.com/daviddedm1/Vision.git
cd Vision

# Build
dotnet build Vision.sln

# Run
dotnet run --project Vision.UI/Vision.UI.csproj
```

### Using Visual Studio 2026

1. Open `Vision.sln` in Visual Studio
2. Build Solution (Ctrl + Shift + B)
3. Run (F5)

## 🎮 How to Use

### Command Center
1. **Left Panel**: Select a group of slides
2. **Center Panel**: Choose a slide
3. **Right Panel**: Preview the selected slide
4. **Send Button**: Display on output window

### Output Window
- Appears on secondary display
- Full-screen mode
- Smooth transitions between slides

## 🔧 Development

### Project Structure
```
Vision/
├── Vision.Core/           # Core logic
│   ├── Slide.cs
│   ├── SlideGroup.cs
│   ├── Playlist.cs
│   └── VisionCore.cs
│
└── Vision.UI/             # WPF Interface
    ├── MainWindow.xaml
    ├── OutputWindow.xaml
    └── App.xaml
```

## 📝 License

MIT License - See LICENSE file for details

## 👨‍💻 Author

**daviddedm1** - Developer

---

**Vision** - Transform your presentations ✨
