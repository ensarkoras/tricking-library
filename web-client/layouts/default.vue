<template>
  <v-app dark>

    <v-app-bar
      dense
      app
    >

      <v-toolbar-title>Tricking Library</v-toolbar-title>

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
