<template>
  <div id="app">
    <div class="container">
      <div class="row">
        <div class="col"></div>
        <div class="col">
          <div class="">
            <img src="./assets/bespokedlogo.png" alt="logo.png">
            <h4>BeSpoked Bikes</h4>
          </div>
          <div class="btn-group">
            <button class="btn btn-primary">Create Sale</button>

            <button class="btn btn-primary">Products</button>
            <button class="btn btn-primary">Customer</button>
          </div>
        </div>
        <div class="col">
          <button class="btn btn-primary">Quarterly Report</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import axios from "axios";
export default {
  name: 'App',
  components: {
  },
  data(){
    return {

    }
  },
  mounted(){
    axios({
      method: 'get',
      url: this.$hostname + 'salesperson',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => console.log(response))
    .catch(err => console.log(err))
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
