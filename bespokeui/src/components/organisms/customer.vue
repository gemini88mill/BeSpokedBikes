<template>
  <div class="container-fluid">
    <div class="row mb-3 border-bottom text-muted">
      <div class="col">Name</div>
      <div class="col">Address</div>
      <div class="col">Phone Number</div>
    </div>
    <div class="row" v-for="item in customers" :key="item.index">
      <div class="col">{{item.name}}</div>
      <div class="col">{{item.address}}</div>
      <div class="col">{{item.phone}}</div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "customer",
  data: function () {
    return {
      customers: []
    }
  },
  mounted() {
    axios({
      method: 'get',
      url: this.$hostname + 'customer',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.customers = response.data)
        .catch(err => console.log(err))
  }
}
</script>

<style scoped>

</style>