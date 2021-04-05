<template>
  <v-app dark>

    <v-app-bar
      dense
      app
    >

      <nuxt-link to="/" class="text-h5 text--primary" style="text-decoration: none">Tricking Library</nuxt-link>

      <v-spacer></v-spacer>

      <content-creation-dialog></content-creation-dialog>

    </v-app-bar>

    <v-main>
      <nuxt />
    </v-main>
  </v-app>
</template>

<script>


export default {
  methods : {
  },
  components : {

  }

}
</script>
