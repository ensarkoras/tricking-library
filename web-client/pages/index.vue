<template>
<div>
  <v-file-input @change="handleFile" accept="video/*" label="Click here to select a file"></v-file-input>

  <div v-if="tricks">
    <p v-for="t in tricks">
      {{ t.name}}
    </p>
  </div>

  <div>
    <v-text-field v-model="trickName" label="Tricking Name"></v-text-field>
    <v-btn @click="saveTrick">Save Trick</v-btn>
  </div>

  {{  message }}
  <v-btn @click="reset">Reset Message</v-btn>
  <v-btn @click="resetTricks">Reset Tricking</v-btn>

</div>
</template>

<script>

import axios  from 'axios'
import {mapState, mapActions, mapMutations} from 'vuex'

export default {
  data : ()=> ({
    trickName : ""
  }),
  /*asyncData(payload){
    return axios.get("http://localhost:5000/api/home")
      .then(({data}) => {
        return { message : data}
      })
  },*/
  computed : {
    ...mapState({
      message : state => state.message
    }),
    ...mapState('tricks', {
      tricks : state => state.tricks
    })
  },
  methods : {
    ...mapMutations(['reset']),
    ...mapMutations('tricks', {
      resetTricks : 'reset'
    }),
    ...mapActions('tricks', ['createTrick']),
    async saveTrick(){
      await this.createTrick({ trick : { name : this.trickName} })
      this.trickName = ""
    },
    async handleFile(file){
      if(!file) return;

      const form = new FormData()
      form.append("video", file)

      const result = await axios.post("http://localhost:5000/api/videos", form)
      console.log("Result : ", result)

    }
  }
 /* async fetch(){
    await this.$store.dispatch("fetchMessage")
  }*/
}
</script>
