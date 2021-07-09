<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
      <router-link to="/read">Read Page</router-link>
    <p>
      I wrote a message to make several test in vue.js
    </p>
    <a href="https://aymerickmichelet.fr" target="_blank" rel="noopener">Exemple of link</a>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
