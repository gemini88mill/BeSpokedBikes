<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col">
        <h4>Products</h4>
      </div>
    </div>
    <div class="row mb-3 border-bottom">
      <div class="col">Manufacturer</div>
      <div class="col">Item Name</div>
      <div class="col">Style</div>
      <div class="col">Purchase Price</div>
      <div class="col">Sale Price</div>
      <div class="col">Quantity on Hand</div>
      <div class="col"></div>
    </div>
    <div class="row mb-3" v-for="item in products" :key="item.index">
      <product-item :product="item" @update="refresh"></product-item>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import ProductItem from "@/components/atoms/productItem";

export default {
  name: "products",
  components: {ProductItem},
  data: function(){
    return {
      products: []
    }
  },
  methods: {
    refresh: function(){
      this.getProducts();
    },
    getProducts: function(){
      axios({
        method: 'get',
        url: this.$hostname + 'products',
        headers: {
          'Access-Control-Allow-Origin': '*'
        }
      }).then(response => this.products = response.data)
          .catch(err => console.log(err))
    }
  },
  mounted(){
    this.getProducts();
  }
}
</script>

<style scoped>

</style>