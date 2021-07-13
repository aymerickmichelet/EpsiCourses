<template>
  <Navbar/>
  <div class="read">
    <h1>This is a read page</h1>
  </div>
</template>

<script>

import Navbar from '@/components/Navbar.vue'

export default {
  name: 'Read',
  components: {
    Navbar
  }
}

</script>