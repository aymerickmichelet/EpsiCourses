module.exports = {
  root: true,
  env: {
    browser: true,
    node: true
  },
  parserOptions: {
    parser: '@babel/eslint-parser',
    requireConfigFile: false
  },
  extends: [
    '@nuxtjs',
    'plugin:nuxt/recommended'
  ],
  plugins: [
  ],
  // add your custom rules here
  rules: {
    'vue/html-indent': ['error', 'tab'],
		'vue/html-closing-bracket-newline': 'off',
		'indent': [2, 'tab'],
		'no-tabs': 'off'
  }
}
