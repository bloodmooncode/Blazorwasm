/** @type {import('tailwindcss').Config} */
module.exports = {
  // 将blazor 会使用到 tailwind 的所有页面
  content: ["**/*.razor", "**/*.cshtml", "**/*.html"],
  theme: {
    extend: {},
  },
  plugins: [],
};
