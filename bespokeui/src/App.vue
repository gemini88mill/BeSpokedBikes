<template>
  <div id="app">
    <div class="container">
      <div class="row">
        <div class="col">
          <div class="">
            <img src="./assets/bespokedlogo.png" alt="logo.png">
            <h4>BeSpoked Bikes</h4>
          </div>
        </div>
        <div class="col">
          <div class="btn-group">
            <button class="btn btn-primary" @click="view = 'report'">Reports</button>
            <button class="btn btn-primary" @click="view = 'products'">Products</button>
            <button class="btn btn-primary" @click="view = 'customer'">Customer</button>
            <button class="btn btn-primary" @click="view = 'sales-people'">Sales</button>
            <button class="btn btn-primary" @click="view = 'sales'">History</button>
          </div>
        </div>
      </div>
      <div class="row">
        <transition name="component-fade" mode="out-in">
          <component v-bind:is="view" :sales-people="users"></component>
        </transition>
<!--        <sales-people :sales-people="users"></sales-people>-->
      </div>
    </div>
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import axios from "axios";
import SalesPeople from "@/components/molecules/SalesPeople";
import Report from "@/components/organisms/report";
import Sales from "@/components/molecules/Sales";
import Products from "@/components/organisms/products";
import customer from "@/components/organisms/customer";
export default {
  name: 'App',
  components: {
    Report,
    SalesPeople,
    Sales,
    Products,
    customer
  },
  data(){
    return {
      users: [],
      view: 'sales-people'
    }
  },
  mounted(){
    axios({
      method: 'get',
      url: this.$hostname + 'salesperson',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.users = response.data)
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

.component-fade-enter-active, .component-fade-leave-active {
  transition: opacity .3s ease;
}
.component-fade-enter, .component-fade-leave-to
  /* .component-fade-leave-active below version 2.1.8 */ {
  opacity: 0;
}
</style>
