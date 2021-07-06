const themeToggle = document.querySelector('#theme-toggle');

themeToggle.addEventListener('click', () => {
    document.body.classList.contains("light-theme") ? enableDarkMode() : enableLightMode()
});

function enableDarkMode() {
    document.body.classList.remove("light-theme");
    document.body.classList.add("dark-theme");
    themeToggle.setAttribute("aria-label", "Switch to light theme");
}

function enableLightMode() {
    document.body.classList.remove("dark-theme");
    document.body.classList.add("light-theme");
    themeToggle.setAttribute("aria-label", "Switch to dark theme");
}

function setThemePreference() {
    if (windows.matchMedia('(prefers-color-scheme: dark)').matches) {
        enableDarkMode();
    } else {
        enableLightMode();
    }
}

document.onload = setThemePreference();