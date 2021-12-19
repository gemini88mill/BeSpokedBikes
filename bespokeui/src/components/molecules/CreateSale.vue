<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col">
        <label>Customer</label>
        <select class="form-select" v-model="customerSelected">
          <option v-for="item in customers" :key="item.index" :value="item.customerId">{{ item.name }}</option>
        </select>
      </div>
      <div class="col">
        <label>Product</label>
        <select class="form-select" v-model="productSelected">
          <option v-for="item in products" :key="item.index" :value="item.productId"> {{ item.manufacturer }} {{ item.name }}</option>
        </select>
      </div>
      <div class="col" v-if="currentProductPrice !== undefined">
        <div class="row-cols-1">Sale Price</div>
        <div class="row-cols-1">
          ${{ formatDecimals(currentProductPrice.salePrice) }}
        </div>
      </div>
      <div class="col" v-else></div>
      <div class="col">
        <button class="btn btn-primary" @click="submitSale()">Submit</button>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "CreateSale",
  props: {
    salesPersonId: Number,
    salesPersonName: String
  },
  data: function (){
    return {
      customers: [],
      products: [],
      productSelected: 0,
      customerSelected: 0
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

    axios({
      method: 'get',
      url: this.$hostname + 'products',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.products = response.data)
        .catch(err => console.log(err))
  },
  computed: {
    currentProductPrice: function () {
      return this.products.find(obj => obj.productId === this.productSelected);
    }
  },
  methods: {
    formatDecimals: function(val){
      return val.toFixed(2)
    },
    submitSale: function(){
      let payload = {
        salesPersonId: this.salesPersonId,
        customerId: this.customerSelected,
        productId: this.productSelected
      }

      console.log(payload);

      axios({
        method: 'post',
        url: this.$hostname + 'sales/newsale',
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-type': 'application/json'
        },
        data: JSON.stringify(payload)
      }).then(response => this.products = response.data)
          .catch(err => console.log(err))
    }
  },

}
</script>

<style scoped>

</style>