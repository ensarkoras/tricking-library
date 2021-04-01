<template>
  <v-app dark>

    <v-app-bar
      dense
      app
    >

      <v-toolbar-title>Tricking Library</v-toolbar-title>

      <v-spacer></v-spacer>

      <video-upload />
    </v-app-bar>

    <v-main>
      <nuxt />
    </v-main>
  </v-app>
</template>

<script>

import VideoUpload from '../components/video-upload'
export default {
  methods : {
  },
  components : {
    VideoUpload
  }

}
</script>
