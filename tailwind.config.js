module.exports = {
  content: [
    "./Views/**/*.cshtml",
    "./wwwroot/js/**/*.js"
  ],
  theme: {
    extend: {
      screens: {
        sm: "640px",
        msm: "600px",
        md: "768px",
        lg: "1024px",
        xl: "1280px",
        "2xl": "1536px",
      },
    },
  },
  plugins: [],
};