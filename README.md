# 🌾 VR Farming Simulation Mini-Game — Unity (Jio Tesseract XR Workshop)
### A VR-based interactive farming experience built during the Jio Tesseract 2-Day XR Workshop  
🏅 **Won 1st Prize (Day 1 & Day 2)**

This project is an interactive **VR farming mini-game** created using **Unity + XR Interaction Toolkit** during the official Jio Tesseract training conducted at NIT Srinagar.

The mini-game simulates planting seeds, watering crops, and growing them through multiple stages — all inside a VR environment with real-time VR interactions.

---

# 📌 1. Project Overview

The goal of the workshop was to learn the fundamentals of XR development and build a working VR experience in just two days.

### ⭐ Final Outcome
A **VR farming simulation** where the player can:

1. **Pick seeds**
2. **Plant seeds onto soil**
3. **Pick up a VR watering can**
4. **Spray water using VR trigger interaction**
5. **Watch plants grow through realistic stages**
6. **Interact naturally with all objects in VR**

The environment was created using a **Farm Environment Asset Pack**.

---

# 🧠 2. Game Mechanics

## 🌱 Seed Planting
- Player grabs seed objects using VR controllers.
- Dropping the seed on the ground triggers:
  - Soil interaction
  - Seed placement
  - Creation of a new plant entity

## 💦 Watering Mechanism
- A VR watering can acts as an interactable tool.
- When the player tilts or presses the trigger:
  - Water particle system activates
  - Water detection uses raycasts/spherecasts
  - Nearby plants receive a `Water()` event

## 🌿 Growth Stages
Each plant progresses through:

1. **Seed**
2. **Plant_Tomato_Small**
3. **Plant_Tomato_Medium**
4. **Plant_Tomato_Large**

Water + time determines growth, simulating basic agronomy.

---

# 🧩 3. Scripts Implemented

### ✔ WaterCan.cs
Handles:
- Player interaction detection  
- Water spray particle emission  
- Raycast/spherecast for plant detection  
- Sending `Water()` signals to plants  

---

### ✔ Seeds.cs
Handles:
- Picking/dropping seeds  
- Detecting drop on **Ground**  
- Creating the first growth-stage plant prefab  

---

### ✔ Plant.cs
Handles:
- Plant growth lifecycle  
- Stage transitions  
- Water-dependent growth  
- Prefab switching across stages  

---

### ✔ Ground.cs
Handles:
- Detecting seed collisions  
- Validating plantable spots  
- Preventing multiple seeds in same location  
- Instantiating initial plant prefab  

---

# 🖼 4. Project Media

Upload all media files in the `media/` folder.

### 🎥 Video Demonstration
- Full gameplay video (plant → water → grow)

### 🖼 Screenshots
- **2 Unity Hierarchy screenshots**
- **4 gameplay screenshots**
- **2 environment setup screenshots**

GitHub automatically renders these using Markdown image tags.

---

# 🕹 5. Gameplay Flow

1. Player loads into a **360° VR farm environment**
2. Picks up seed objects using XR Interaction Toolkit  
3. Drops seeds onto ground → first growth stage appears  
4. Picks up watering can  
5. Sprays water on plant  
6. Plant transitions:
   - Small → Medium → Large  
7. Repeat for multiple seeds  

A smooth VR interaction loop with rewarding visual feedback.

---

# 🎮 6. Tools & Technologies

- **Unity 2021/2022 LTS**
- **XR Interaction Toolkit (XRI)**
- **Jio Tesseract XR Workshop Setup**
- **C# Scripting**
- **Unity Particle Systems**
- **Trigger Colliders + Physics**
- **Farm Environment 3D Pack**
- **Android Build (VR headset deployment)**

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

- Completed **Official Jio Tesseract XR Training Workshop**
- Built a fully functional VR game in **under 48 hours**
- Learned:
  - XR interaction systems  
  - VR physics  
  - Environment design  
  - Prefab workflows  
  - Unity event-driven scripting  
- **Won 1st Prize (both Day 1 & Day 2)**  
  - Based on creativity, polish, and technical execution  

---

# 🚀 9. Future Improvements

- Add smart irrigation using soil moisture sensors  
- Add Day–Night cycle  
- Replace prefab switching with growth shaders  
- Haptic feedback support  
- Add more crops: maize, wheat, rice  
- Add fertilizers for accelerating growth  
- Add scoring / farming progression system  
- Add multiplayer co-op VR farming  

---

# 🧑‍💻 10. Author

**Arnav Saxena**  
AI/ML • Computer Vision • XR/VR • Robotics  
📧 Email: **arnav12saxena@gmail.com**  
🔗 LinkedIn: https://www.linkedin.com/in/arnav-saxena-a9a217367  

---
