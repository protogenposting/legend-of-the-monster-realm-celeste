local utils = require("utils")

local LaunchBlock = {}

LaunchBlock.name = "legendofthemonsterrealm/LaunchBlock"
LaunchBlock.color = {0.8, 0.4, 0.4, 0.8}
LaunchBlock.canResize = {true, true}
LaunchBlock.placements = {
    name = "legendofthemonsterrealm/LaunchBlock",
    data = {
        width = 8,
		height = 8,
    }
}

function LaunchBlock.rectangle(room, entity)
    return utils.rectangle(entity.x, entity.y, entity.width or 8, entity.height or 8)
end

return LaunchBlock