<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col text-start"><h5>Sales People</h5></div>
    </div>
    <div class="row border-bottom mb-3">
      <div class="col text-muted">Name</div>
      <div class="col text-muted">Manager</div>
      <div class="col text-muted"></div>
    </div>
    <div class="row mb-3" v-for="item in salesPeople" :key="item.index">
      <sales-person :sales-person="item" @saleEvent="createSale" @update="updateSalesPeople"></sales-person>
    </div>
    <div class="row" v-show="createSaleView === true">
      <create-sale :sales-person-id="salesPerson"></create-sale>
    </div>
  </div>
</template>

<script>
import SalesPerson from "@/components/atoms/Salesperson";
import CreateSale from "@/components/molecules/CreateSale";
export default {
  name: "SalesPeople",
  components: {CreateSale, SalesPerson},
  props: {
      salesPeople: Array
  },
  data: function () {
    return {
      createSaleView: false,
      salesPerson: null
    }
  },
  methods: {
    createSale: function(val){
      this.createSaleView = true;
      this.salesPerson = val;

    },
    updateSalesPeople: function(){
      this.$emit('update', true);
    }
  }
}
</script>

<style scoped>

</style>