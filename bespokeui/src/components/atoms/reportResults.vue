<template>
  <div class="container-fluid">
    <div class="row text-muted border-bottom">
      <div class="col ">Name</div>
      <div class="col">Number of Sales</div>
      <div class="col">Commission Total</div>
      <div class="col">Total Sales</div>
    </div>
    <div class="row" v-for="item in results" :key="item.index">
      <div class="col">{{item.salesPersonName}}</div>
      <div class="col">{{ item.salesCount }}</div>
      <div class="col text-end">${{formatDecimals(item.commissionTotal)}}</div>
      <div class="col text-end">${{formatDecimals(item.totalSales)}}</div>
    </div>
  </div>
</template>

<script>
export default {
  name: "reportResults",
  props: {
    results: Array
  },
  methods: {
    formatDecimals: function(val){
      return val.toFixed(2)
    }
  }
}
</script>

<style scoped>

</style>