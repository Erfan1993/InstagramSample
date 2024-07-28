using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstagramSample.Basic
{
    public abstract class ControllerWithBaseVerbs : InstagramBaseController
    {
        [HttpGet]
        [Route("{id}")]
        public virtual IActionResult GetByID_Body([FromBody] Guid id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public virtual IActionResult GetByID_Route([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] dynamic inModel)
        {
            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody] dynamic inModel)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual IActionResult Delete([FromBody] dynamic inModel)
        {
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public virtual IActionResult Delete_Route([FromRoute] dynamic inModel)
        {
            return Ok();
        }
    }
}
