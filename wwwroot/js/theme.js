window.appTheme = {
    get: function () {
        const value = localStorage.getItem("app-theme");
        return value || "light";
    },
    set: function (theme) {
        const normalized = theme === "dark" ? "dark" : "light";
        localStorage.setItem("app-theme", normalized);
        document.documentElement.setAttribute("data-theme", normalized);
    },
    toggle: function () {
        const current = this.get();
        const next = current === "dark" ? "light" : "dark";
        this.set(next);
        return next;
    },
    init: function () {
        const value = this.get();
        document.documentElement.setAttribute("data-theme", value);
        return value;
    }
};
