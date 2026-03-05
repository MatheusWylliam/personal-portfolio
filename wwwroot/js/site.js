const name = "Matheus W. :)";
const el = document.getElementById("typewriter");
let i = 0;

function type() {
    if (i < name.length) {
        el.textContent += name.charAt(i);
        i++;
        setTimeout(type, 85);
    }
}

function selectExp(index) {
    const isLight = document.getElementById("body-root").classList.contains("light-mode");
    const activeColor = isLight ? "#111111" : "#f0f0f0";
    const activeBg = isLight ? "rgba(0,0,0,0.05)" : "rgba(255,255,255,0.04)";

    document.querySelectorAll("[id^='exp-panel-']").forEach(function (panel) {
        panel.style.display = "none";
    });

    document.querySelectorAll(".exp-btn").forEach(function (btn) {
        btn.style.color = "";
        btn.style.borderLeftColor = "transparent";
        btn.style.backgroundColor = "";
    });

    var panel = document.getElementById("exp-panel-" + index);
    if (panel) panel.style.display = "block";

    var btn = document.getElementById("btn-exp-" + index);
    if (btn) {
        btn.style.color = activeColor;
        btn.style.borderLeftColor = activeColor;
        btn.style.backgroundColor = activeBg;
    }
}

function toggleTheme() {
    const body = document.getElementById("body-root");
    const icon = document.getElementById("theme-icon");
    const isLight = body.classList.toggle("light-mode");
    icon.textContent = isLight ? "☾" : "☀";
    localStorage.setItem("theme", isLight ? "light" : "dark");
    selectExp(currentExp);
}

let currentExp = 0;

function selectExpAndTrack(index) {
    currentExp = index;
    selectExp(index);
}

document.addEventListener("DOMContentLoaded", function () {
    type();
    selectExpAndTrack(0);

    document.querySelectorAll("[id^='btn-exp-']").forEach(function (btn) {
        const index = parseInt(btn.id.replace("btn-exp-", ""));
        btn.setAttribute("onclick", "selectExpAndTrack(" + index + ")");
    });

    const saved = localStorage.getItem("theme");
    if (saved === "light") {
        document.getElementById("body-root").classList.add("light-mode");
        document.getElementById("theme-icon").textContent = "☾";
        selectExp(0);
    }
});