# 🎨 Modern Paint Application (C# WinForms)

A feature-rich 2D drawing application developed using **C#**, **WinForms**, and the **GDI+** library. This project showcases advanced graphics programming, including custom drawing algorithms and UI management.

---

## 🚀 Main Features

### 🖌️ Drawing Tools
* **Freehand Drawing:** Smooth **Pencil** and **Brush** tools with adjustable stroke thickness.
* **Eraser:** Precision eraser to clean up specific parts of your drawing.
* **Line Tool:** Draw perfect straight lines between two points.

### 📐 Geometry Shapes
* **Standard Shapes:** Draw Rectangles and Ellipses.
* **Perfect Shapes:** Custom logic to draw perfect **Squares** and **Circles**.
* **Polygons:** Draw **Triangles** with dynamic vertex calculation.
* **Fill Option:** A toggleable feature to draw either the **Outline** or a **Solid Filled** shape.

### 🎨 Color & Effects
* **Flood Fill (Bucket):** Advanced **Stack-based Flood Fill algorithm** to color entire closed areas instantly.
* **Color Palette:** Full integration with `ColorDialog` for infinite color choices.

---

## 🛠️ Technical Highlights

* **Persistent Graphics:** Uses a `Bitmap` buffer (Memory-based drawing). Your art won't disappear when the window is resized or minimized!
* **Optimized Performance:** The **Flood Fill** algorithm is optimized with a `Stack<Point>` to prevent memory overflow and ensure smooth performance.
* **Clean UI:** Shapes are organized in a collapsible **Shapes Panel** to keep the workspace clean.
* **Anti-Aliasing:** Uses `LineCap.Round` and `SmoothingMode` for professional, smooth-looking strokes.


## 🏗️ How to Run

1.  **Clone the Repo:**
    ```bash
    git clone [https://github.com/AnSmacckken/Paint-app-cs.git](https://github.com/AnSmacckken/Paint-app-cs.git)
    ```
2.  **Open in Visual Studio:** Launch the `.sln` file.
3.  **Build & Run:** Press `F5` to start drawing!

---

## 📂 Project Structure
* `Form1.cs`: Contains the core logic for drawing events and algorithms.
* `FloodFill`: Custom implementation of the area-filling algorithm.
* `Resources`: Contains icons and UI assets.

---

## 🤝 Contributing
Feel free to fork this project and add your own features, like:
- [ ] Adding a "Save Image" button.
- [ ] Implementing "Undo/Redo" functionality.
- [ ] Text insertion tool.

**Made with ❤️ by [AnS MAacCKken]**