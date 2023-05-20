function toggleTheme(theme) {

    if (theme === "light")
        setTheme("light");
    else
        setTheme("dark");
}

function setTheme(theme) {
    document.documentElement.setAttribute("data-theme", theme);
    return theme === "dark";
}