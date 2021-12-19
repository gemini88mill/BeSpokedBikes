<template>
  <div class="container-fluid">
    <div class="row mb-3 border-bottom">
      <div class="col">Product</div>
      <div class="col">Customer</div>
      <div class="col">Date</div>
      <div class="col">Price</div>
      <div class="col">Salesperson</div>
      <div class="col">Commission</div>
    </div>
    <transition-group name="flip-list" tag="div" class="sales">
      <div class="row sales" v-for="(item, index) in sales" :key="index">
        <div class="col">{{ item.productName }}</div>
        <div class="col">{{ item.customerName }}</div>
        <div class="col">{{item.saleDate}}</div>
        <div class="col">${{formatDecimals(item.price)}}</div>
        <div class="col">{{item.salesPersonName}}</div>
        <div class="col">${{formatDecimals(item.commission)}}</div>
      </div>
    </transition-group>
    <button class="btn btn-primary" type="button" @click="sort">Sort by Date</button>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "Sales",
  data: function () {
    return {
      sales: []
    }
  },
  mounted() {
    axios({
      method: 'get',
      url: this.$hostname + 'sales',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.sales = response.data)
        .catch(err => console.log(err))
  },
  methods: {
    formatDecimals: function(val){
      return val.toFixed(2)
    },
    sort: function(){
      this.sales = this.sales.sort((a,b) => (a.saleDate > b.saleDate) ? 1 : -1)
    }
  },
}
</script>

<style scoped>
.flip-list-move {
  transition: transform 1s;
}
</style>