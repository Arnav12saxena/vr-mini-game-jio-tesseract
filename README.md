# 🌾 VR Farming Simulation Mini-Game — Unity (Jio Tesseract XR Workshop)  
### Immersive VR Agriculture Experience · Unity XR Interaction Toolkit · 1st Prize Winner  
🏅 **Awarded 1st Prize on Both Days of the Jio Tesseract XR Workshop at NIT Srinagar**

This project is a complete **VR farming simulation mini-game** built during the official *Jio Tesseract 2-Day XR Workshop*.  
It demonstrates interactive seed planting, crop watering, and plant growth inside a fully immersive virtual farm environment.

The project blends:  
- **VR interactions**  
- **C# scripting**  
- **Dynamic crop lifecycle mechanics**  
- **Particle systems**  
- **Optimized prefab workflows**  
- **Unity XR Interaction Toolkit**  

A strong demonstration of rapid prototyping and VR development skills.

---

# 📌 1. Project Overview

During the workshop, participants were challenged to design a working VR experience in under 48 hours.  
This project evolved into a **farming simulation**, letting players interact directly with seeds, soil, water, and plant growth systems.

### 🎮 Final Gameplay Features
- Pick up seed objects  
- Plant seeds into specific soil areas  
- Water plants using a VR watering can  
- Growth mechanics: seed → small → medium → large plant  
- Natural VR interactions using ray + direct grabbing  
- Beautiful farm environment using 3D asset packs  
- Smooth interactions powered by **Unity XR Interaction Toolkit**

### 🌟 Notable Achievement
🏆 **Won 1st Prize on both days** based on:
- Creativity  
- Technical execution  
- Realistic VR interactions  
- Polish & immersive experience  
- Proper use of XR tooling  

---

# 🧠 2. Game Design & Mechanics

A simplified but interactive agricultural lifecycle.

---

## 🌱 2.1 Seed Planting System

Seed objects act as **XR Grab Interactables**:
- Pick-up using VR controller grip  
- Drop seeds on valid soil  
- Soil detects impact → spawns first plant stage  
- Prevents duplicate planting  
- Seeds disappear after planting  

Script-driven planting logic:
- Soil detection  
- Prefab instantiation  
- Start of the plant growth timer  

---

## 💧 2.2 Watering Mechanism — Functional VR Tool

The watering can uses:
- XR Grab Interactable  
- Particle emitter simulating water  
- Raycast/spherecast to detect plant hit  
- Input-driven activation (trigger press)

Plant receives `Water()` calls when hit by water spray, enabling growth progression.

---

## 🌿 2.3 Plant Growth Lifecycle

Each plant transitions through:

1. **Seed Stage** (spawned from soil)  
2. **Plant_Tomato_Small**  
3. **Plant_Tomato_Medium**  
4. **Plant_Tomato_Large**  

Growth rules:
- Timer-based transitions  
- Requires water to proceed  
- Prefab swapping logic handled by script  
- Prevents stage skipping  

---

# 🧩 3. Core C# Scripts

### ✔ 3.1 WaterCan.cs  
Responsible for:
- Detecting pick-up events  
- Enabling/disabling water particle spray  
- Performing raycast/spherecast checks  
- Sending `Water()` calls to Plant.cs  
- Input-trigger sensors

---

### ✔ 3.2 Seeds.cs  
Controls:
- Seed pick/drop behavior  
- Soil collision detection  
- Spawning initial plant prefab  
- Deleting seed after planting  
- Preventing double planting  

---

### ✔ 3.3 Plant.cs  
Manages:
- Current growth stage  
- Timed stage transitions  
- Responding to water  
- Swapping visual prefabs  
- Ensuring realistic growth pacing  

---

### ✔ 3.4 Ground.cs  
Handles:
- Soil collision logic  
- Detection of seed drops  
- Valid placement zone checks  
- Instantiating stage-1 plant prefab  
- Preventing overlapping plant spawns  

---

# 🖼 4. Media & Visual Demonstrations

> Place all assets inside the `/media` folder.

### 🎥 Suggested Video Demo  
- Full gameplay recording (MP4)

### 🖼 Screenshots
- **4 gameplay screenshots**  
- **2 Unity hierarchy screenshots**  
- **2 environment setup screenshots**  

These help present the project effectively on GitHub.

---

# 🕹 5. XR Interaction Toolkit Setup

### 🎯 XR Rig Components
- **XR Origin**  
- VR Camera (HMD Tracking)  
- Left & Right Controllers:  
  - Ray Interactor  
  - Direct Interactor  
  - Line Renderer  
- Interaction Layer Masks  
- Input Action Manager  
- XRI Default Input Action asset  

### 🎮 Interaction Types Used
- Grab Interactables  
- Object collisions/triggers  
- Ray-based interaction  
- Particle-based collision “water” detection  
- Prefab switching (growth stages)  

---

# 🛠 6. Tools & Technology Stack

- **Unity 2021/2022 LTS**  
- **XR Interaction Toolkit**  
- **Jio Tesseract (Workshop Tools)**  
- **C# MonoBehaviour scripting**  
- **Unity Particle System**  
- **Oculus/VR Headset deployment**  
- **3D Farm Environment Assets**  
- **XR Input Action Mapping**  

---

# 📦 7. Project Structure

```
vr-mini-game-jio-tesseract/
│── Assets/
│   ├── Scripts/
│   │   ├── WaterCan.cs
│   │   ├── Seeds.cs
│   │   ├── Plant.cs
│   │   └── Ground.cs
│   ├── Prefabs/
│   │   ├── Seed.prefab
│   │   ├── Plant_Tomato_Small.prefab
│   │   ├── Plant_Tomato_Medium.prefab
│   │   └── Plant_Tomato_Large.prefab
│   ├── Environment/
│   └── XR Rig & Interaction Setup
│
├── media/
│   ├── gameplay_1.png
│   ├── gameplay_2.png
│   ├── gameplay_3.png
│   ├── gameplay_4.png
│   ├── hierarchy_1.png
│   ├── hierarchy_2.png
│   ├── setup_1.png
│   ├── setup_2.png
│   └── demo_video.mp4
│
└── README.md
```

---

# 🏅 8. Achievements

### ✔ Completed official **Jio Tesseract XR Training Program**  
### ✔ Built an entire VR game in **less than 48 hours**  
### ✔ Mastered:
- VR Interaction systems  
- Physics-based object handling  
- Prefab-driven gameplay design  
- Efficient XR interaction flows  

### ✔ **Won 1st Prize (both days)** for:
- Innovation  
- Technical execution  
- Interaction quality  
- Smoothness and polish  
- Creative environment design  

A standout project for XR/VR portfolios.

---

# 🚀 9. Future Improvements

- 🌧 Dynamic weather (rain, storms, clouds)  
- 🌗 Day–Night lighting cycle  
- 🌾 Support additional crops (rice, maize, wheat)  
- ⚗ Fertilizer mechanics for faster plant growth  
- 🔊 Audio effects (water splash, ambience)  
- 📦 Inventory & farming progression  
- 🧑‍🌾 Multiplayer co-op farming  
- 🤖 Integration with real IoT sensors for educational AR/VR agriculture  

---

# 🧑‍💻 10. Author

**Arnav Saxena**  
AI/ML • Computer Vision • XR/VR • Robotics • Agri-Tech  
📧 Email: **arnav12saxena@gmail.com**  
🔗 LinkedIn: **https://www.linkedin.com/in/arnav-saxena-a9a217367**  

---
