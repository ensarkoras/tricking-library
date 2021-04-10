<template>
  <div>
    <v-btn :key="i.id" v-for="i in items" :to="`/moderation/${i.type}/${i.target}`">
      {{i.target}}
    </v-btn>
  </div>
</template>

<script>
export default {
  data : () => ({
    items : []
  }),
  async fetch(){
    this.items = await this.$axios.$get("/api/moderation-items")
  }
}
</script>

<style scoped>

</style>
