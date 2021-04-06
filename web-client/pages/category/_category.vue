<template>
  <item-content-layout>
    <template v-slot:content>
      <trick-list :tricks="tricks"></trick-list>
    </template>
    <template v-slot:item>
      <div v-if="category">
        <div class="text-h6">{{ category.name }}</div>
        <v-divider class="my-1"></v-divider>
        <div class="text-body-2">{{ category.description }}</div>
      </div>
    </template>
  </item-content-layout>
</template>

<script>
import {mapGetters} from 'vuex'

export default {
  data:() => ({
    category : null,
    tricks : [],
  }),
  computed : {
    ...mapGetters('tricks', ['categoryById']),
  },
  head() {
    if(!this.category) return {}
    return {
      title : this.category.name,
      meta: [
        { hid: 'description', name: 'description', content: this.category.description }
      ]
    }
  },
  async fetch(){
    const categoryId = this.$route.params.category
    this.category = this.categoryById(categoryId)
    this.tricks = await this.$axios.$get(`/api/categories/${categoryId}/tricks`)
  }

}
</script>

<style scoped>

</style>
