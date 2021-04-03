const initState = () => ({
  uploadPromise : null,
  active :false,
  component : null
  //type :"",
})

export const state = initState

export const mutations = {
  activate(state, {component}){
    state.active = true
    //state.type = type
    state.component = component
  },
  hide(state){
    state.active = false
  },
  setTask(state, {uploadPromise}){
    state.uploadPromise = uploadPromise
    state.step++
  },
  reset(state){
    Object.assign(state, initState())
  }
}

export const actions = {
  startVideoUpload({commit, dispatch}, {form}){
    const uploadPromise = this.$axios.$post("/api/videos", form)
    commit("setTask" , {uploadPromise})
  },
  async createSubmission({state, commit, dispatch}, {form}){
    if(!state.uploadPromise){
      console.log("uploadTask is null")
      return;
    }

    form.video = await state.uploadPromise
    await dispatch('submissions/createSubmission', {form} , {root : true})
    commit('reset')
  }
}
